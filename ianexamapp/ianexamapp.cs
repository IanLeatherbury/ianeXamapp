using System;
using System.IO;
using System.Reflection;
using eXam;
using Xamarin.Forms;

namespace ianexamapp
{
	public class App : Application
	{
		public static Game CurrentGame { get; private set; }
		public App()
		{
			// The root page of your application
			MainPage = new NavigationPage(new HomePage());
		}

		//protected override void OnStart ()
		//{
		//          // Handle when your app starts
		//          var stream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("ianexamapp.Data.questions.xml");
		//          var questionText = new StreamReader(stream).ReadToEnd();
		//    var questions = QuizQuestionXmlSerializer.Deserialize(questionText);

		//          CurrentGame = new Game(questions);

		//}

		async protected override void OnStart()
		{
			var fileHelper = DependencyService.Get<IFileHelper>();

			string questionText = await fileHelper.LoadLocalFileAsync("cachedquestions.xml");

			if (questionText == null)
			{
				// no cached version available, load from PCL
				using (var stream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("ianexamapp.Data.questions.xml"))
				{
					questionText = new StreamReader(stream).ReadToEnd();
				}
			}

			await fileHelper.SaveLocalFileAsync("cachedquestions.xml", questionText);

			var questions = QuizQuestionXmlSerializer.Deserialize(questionText);

			CurrentGame = new Game(questions);
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

