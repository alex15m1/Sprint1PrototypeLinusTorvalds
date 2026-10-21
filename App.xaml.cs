
﻿namespace AdaptedPhysicalEducationApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	private const int pageToShow = 0;
	private static readonly Func<Page>[] PageSelection =
	[
		() => new AdaptedPE.HomePage(),
		() => new AdaptedPE.SchoolLevelPage(),
		() => new AdaptedPE.TeacherSignInPage(),
		() => new Views.ActivitiesPage(),
		() => new Views.BasketballPage(),
		() => new Views.LessonPlansPage(),
		() => new MainPage()
	];

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(PageSelection[pageToShow]());
	}
}

