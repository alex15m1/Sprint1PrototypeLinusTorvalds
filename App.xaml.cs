using Microsoft.Extensions.DependencyInjection;

namespace AdaptedPhysicalEducationApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	private readonly Func<ContentPage>[] Pages =
	{
	// () => new DrillsPage(),
	// () => new DrillDetailsPage()
	};

	private const int pageToShow = 0;

	protected override Window CreateWindow(IActivationState? activationState)
	{
		
		//return new Window(new EquipmentDetails());
		//return new Window(new EquipmentModifications());
		return new Window(new StudentSupportStrategies());
	}
}