using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using TriggerAndTakePhoto.Services.CameraService;

namespace WpfToupcamLearning;

// todo: stop
// todo: pause
// todo: snap
// todo: trigger

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty] private string _message;
    [ObservableProperty] private string _imagePath;


    private ToupcamService? _cam;

    
    [RelayCommand]
    private void EnumV2()
    {
        Message = string.Empty;
        var devices = ToupcamService.EnumV2();
        foreach (var device in devices)
        {
            Message += device.id + Environment.NewLine;
        }
    }

    [RelayCommand]
    private void Open()
    {
        var devices = ToupcamService.EnumV2();
        if (devices.Length == 0) return;
        var device = devices[0];
        _cam = ToupcamService.Open($"{device.id}");


        // // auto exposure
        _cam.put_AutoExpoEnable(false);
        _cam.put_ExpoTime(450000);
        _cam.put_ExpoAGain(100);
        // _cam.AwbInit();
        // _cam.AwbOnce();
        // _cam.put_AutoExpoTarget(120);
        // _cam.put_MaxAutoExpoTimeAGain(350, 100);
        // _cam.put_Option(Nncam.eOPTION.OPTION_RAW, 0); // rgb
        _cam.put_Option(ToupcamService.eOPTION.OPTION_TRIGGER, 1); // software trigger
        // _cam.put_Option(Nncam.eOPTION.OPTION_RGB, 2);

        if (_cam is null)
            MessageBox.Show("Open failed");
        else
        {
            Message += "Camera opened" + Environment.NewLine;
            _cam.get_Size(out var width, out var height);
            Message += $"Size: {width}x{height}" + Environment.NewLine;
            _cam.get_ExpoTime(out var expoTime);
            Message += $"ExpoTime: {expoTime}" + Environment.NewLine;
            _cam.get_ExpoAGain(out var expoAGain);
            Message += $"ExpoAGain: {expoAGain}" + Environment.NewLine;
        }

    }


    [RelayCommand]
    private void Close()
    {
        if (_cam is null)
            MessageBox.Show("camera is not opened");
        else
        {
            _cam.Close();
            Message += "Camera closed";
        }
    }

    [RelayCommand]
    private void StartPullWithCallBack()
    {
        if (_cam is null) return;


        if (_cam.StartPullModeWithCallback(PullModeCallback))
            Message += "StartPullWithCallBack success" + Environment.NewLine;
        else
            MessageBox.Show("StartPullWithCallBack failed");
    }


    [RelayCommand]
    private void Trigger()
    {
        if (_cam != null && _cam.Trigger(1))
            Message += "Trigger success" + Environment.NewLine;
        else
            MessageBox.Show("Trigger failed");
    }


    private void PullModeCallback(ToupcamService.eEVENT ev)
    {
        switch (ev)
        {
            case ToupcamService.eEVENT.EVENT_EXPOSURE:
                break;
            case ToupcamService.eEVENT.EVENT_TEMPTINT:
                break;
            case ToupcamService.eEVENT.EVENT_CHROME:
                break;
            case ToupcamService.eEVENT.EVENT_IMAGE:
                // todo: pull image
                // pull image
                ImagePath = PullImage();
                Message += "EVENT_IMAGE" + Environment.NewLine;
                break;
            case ToupcamService.eEVENT.EVENT_STILLIMAGE:
                break;
            case ToupcamService.eEVENT.EVENT_WBGAIN:
                break;
            case ToupcamService.eEVENT.EVENT_TRIGGERFAIL:
                break;
            case ToupcamService.eEVENT.EVENT_BLACK:
                break;
            case ToupcamService.eEVENT.EVENT_FFC:
                break;
            case ToupcamService.eEVENT.EVENT_DFC:
                break;
            case ToupcamService.eEVENT.EVENT_ROI:
                break;
            case ToupcamService.eEVENT.EVENT_LEVELRANGE:
                break;
            case ToupcamService.eEVENT.EVENT_ERROR:
                break;
            case ToupcamService.eEVENT.EVENT_DISCONNECTED:
                break;
            case ToupcamService.eEVENT.EVENT_NOFRAMETIMEOUT:
                break;
            case ToupcamService.eEVENT.EVENT_AFFEEDBACK:
                break;
            case ToupcamService.eEVENT.EVENT_AFPOSITION:
                break;
            case ToupcamService.eEVENT.EVENT_NOPACKETTIMEOUT:
                break;
            case ToupcamService.eEVENT.EVENT_EXPO_START:
                break;
            case ToupcamService.eEVENT.EVENT_EXPO_STOP:
                break;
            case ToupcamService.eEVENT.EVENT_TRIGGER_ALLOW:
                break;
            case ToupcamService.eEVENT.EVENT_FACTORY:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(ev), ev, null);
        }
    }


    private string PullImage()
    {
        if (_cam is null) return string.Empty;
        if (!_cam.get_Size(out var width, out var height)) return string.Empty;

        var tempImage = new Bitmap(width, height, PixelFormat.Format24bppRgb);
        var data = tempImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadWrite,
            tempImage.PixelFormat);
        if (!_cam.PullImageV2(data.Scan0, 24, out var info)) return string.Empty;
        Message += info.timestamp + Environment.NewLine;
        tempImage.UnlockBits(data);
        var fileName = Path.Combine(Path.GetTempPath(), $"temp_{DateTime.Now.ToString("yyyyMMddhhmmssfff")}.jpg");
        tempImage.Save(fileName, ImageFormat.Bmp);
        return fileName;
    }
}