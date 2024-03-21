using AVFoundation;
using Microsoft.Extensions.Logging;
using Plugin.Maui.Audio;

namespace LearnRussian;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts => { fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular"); });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddScoped<MarkdownService>();
        
#if IOS
        AVAudioSession.SharedInstance().SetCategory(AVAudioSessionCategory.Playback);
#endif
        
#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif
        builder.Services.AddSingleton(AudioManager.Current);

        return builder.Build();
    }
}