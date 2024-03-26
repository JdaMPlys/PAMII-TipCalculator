namespace tipCalculator
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void PercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPercentageLabel.Text = $"{PercentageSlider.Value.ToString()}%";
        }

        private void Button15Percent_Clicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 15;
        }

        private void Button30Percent_Clicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 30;
        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {
            //Armazenar esse valor em uma variável
            //Chama o metodo que calcula a gorjeta
            double tip = CalculateTip();
            tip = Math.Ceiling(tip);
            TipLabel.Text = Convert.ToString(tip);

            //Exibir o valor da gorjeta arredondado para cima
            double valorRefeicao = tip + Convert.ToDouble(ValueEntry.Text);
            //Exibir o valor total da refeição
            ValueTotalLabel.Text = valorRefeicao.ToString();
            
        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
            //Armazenar esse valor em uma variável
            //Chama o metodo que calcula a gorjeta
            double tip = CalculateTip();
            tip = Math.Floor(tip);
            TipLabel.Text = Convert.ToString(tip);

            //Exibir o valor da gorjeta arredondado para cima
            double valorRefeicao = tip + Convert.ToDouble(ValueEntry.Text);
            //Exibir o valor total da refeição
            ValueTotalLabel.Text = valorRefeicao.ToString();
        }

        private double CalculateTip()
        {
            //Pegar o valor da refeição
            //Armazenar esse valor em uma variável
            double valRefeicao = Convert.ToDouble(ValueEntry.Text);

            //Pegar o valor que o usuário definiu no slider
            double valPorcentagem = PercentageSlider.Value;

            //Calcular o valor da gorjeta
            double valorGorjeta = valRefeicao * (valPorcentagem / 100);

            //Retornar o valor do calculo 
            return (valorGorjeta);
        }
    }

}
