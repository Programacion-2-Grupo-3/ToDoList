using ToDoList.Views;

namespace ToDoList
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new TareaMain());
        }
    }
}
