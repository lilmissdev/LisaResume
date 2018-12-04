using LisaResume.Windows;

using System.Windows;

using LisaResume.Pages;

namespace LisaResume
{
    /*
     *      If you are reading this:
     *
     *      Thank you for taking the time to review my code! In this code set, I do the same thing several different ways sometimes so I can show off the various ways of doing any given task.
     *
     *      An example of this would be the public bool isSaved has the method-style getters and setters whereas the public string FilePath uses the auto getters and setters.
     *
     *      Additionally, please take the time to review Translator.cs, Singleton.cs, Itranslatable.cs, and Classbuilder.cs. I made those classes to to demonstrate some Object Oriented programming techniques.
     *          •   Translator.cs is a parent class. I could have made it abstract, as it is never instantiated. Instead, it contains properties and methods that all the translator classes inherit.
     *          •   Singleton.cs is just what it sounds like. It's a singleton. I use it to hold certain properties that I need to access regardless of what class I'm currently using.
     *          •   Itranslatable.cs is an interface with methods such as Save(), Translate(), Load() and Publish() which I want all of my translator classes to implement.
     *          •   ClassBuilder.cs has a variety of methods that I use for the implementation of my code. Ultimately, several methods are unused, as I decided to go a different route in code. But I left them there as they showcase other c# concepts.
     *
     *
     *      Thanks again for taking the time to read my code. I really hope it impresses you and I would love to get the chance to come in for an interview.
     *          Lisa Connell
     * */
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_WatchNow_Click(object sender, RoutedEventArgs e)
        {
            VideoWindow win2 = new VideoWindow();
            win2.Show();
        }

        private void Button_AboutMe_Click(object sender, RoutedEventArgs e)
        {
            AboutMeWindow win3 = new AboutMeWindow();
            win3.Show();
        }

        private void Button_SampleCode_Click(object sender, RoutedEventArgs e)
        {
            SampleCodeWindow win4 = new SampleCodeWindow();
            win4.WindowStartupLocation =  WindowStartupLocation.CenterScreen;
            win4.SourceInitialized     += (s, a) => win4.WindowState = WindowState.Maximized;
            win4.Show();

            //Main.Content = new SampleCodePage("");
        }

        private void Button_NextSteps_Click(object sender, RoutedEventArgs e)
        {
            image.Visibility = Visibility.Hidden;
            block.Visibility = Visibility.Hidden;
            textBlock.Visibility = Visibility.Hidden;
            aboutMe.Visibility = Visibility.Hidden;
            watchNowButton.Visibility = Visibility.Hidden;
            nextSteps.Visibility = Visibility.Hidden;
            sampleCode.Visibility = Visibility.Hidden;
            Main.Content = new NextStepsPage1();
        }
    }
}
