
using AdaptedPhysicalEducationApp.Views;

namespace AdaptedPhysicalEducationApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    // Sprint 1 prototype screens
    private readonly Func<ContentPage>[] Pages =
    {
        () => new ActivitiesPage(),   // Screen 3
        () => new BasketballPage(),   // Screen 4
        () => new LessonPlansPage()    // Screen 9
    };

    // Change this number to display another screen
    private const int pageToShow = 0;

    protected override Window CreateWindow(
        IActivationState? activationState)
    {
        return new Window(Pages[pageToShow]());
    }
}
