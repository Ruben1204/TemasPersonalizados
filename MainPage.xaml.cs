namespace TemasPersonalizados
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ICollection<ResourceDictionary> mergeDicitionaries = Application.Current.Resources.MergedDictionaries;
            if(mergeDicitionaries != null)
            {
                mergeDicitionaries.Clear();
                mergeDicitionaries.Add(new TemaClaro());
            }
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ICollection<ResourceDictionary> mergeDicitionaries = Application.Current.Resources.MergedDictionaries;
            if (mergeDicitionaries != null)
            {
                mergeDicitionaries.Clear();
                mergeDicitionaries.Add(new TemaOscuro());
            }
        }
    }

}
