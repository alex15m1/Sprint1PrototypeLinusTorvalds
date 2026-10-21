namespace AdaptedPE;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    private const int pageToShow = 0;
    private static readonly Func<Page>[] PageSelection =
    [
        () => new HomePage(),
        () => new SchoolLevelPage(),
        () => new TeacherSignInPage(),
        () => new AdaptedPhysicalEducationApp.MainPage()
    ];

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(PageSelection[pageToShow]());
    }
}
