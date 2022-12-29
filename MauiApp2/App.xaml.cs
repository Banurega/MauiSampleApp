namespace MauiApp2;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
        SecureStorage.SetAsync("sample", "sample");
        var sample = SecureStorage.GetAsync("sample").Result;
    }
}