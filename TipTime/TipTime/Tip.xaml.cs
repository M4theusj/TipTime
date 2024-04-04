namespace TipTime;

public partial class Tip : ContentPage
{
	public Tip()
	{
		InitializeComponent();
	}

    private void Percentage15Button_Clicked(object sender, EventArgs e)
    {
        GorjetaSlider.Value = 15;
    }

    private void Percentage30Button_Clicked(object sender, EventArgs e)
    {
        GorjetaSlider.Value = 30;
    }

    private void RoundUpButton_Clicked(object sender, EventArgs e)
    {
        double valorDaRefeição = Convert.ToDouble(ValueEntry.Text);
        double valorDoSlider = Convert.ToDouble(TipPer.Text);
        double valorDaGorjeta = (valorDoSlider * valorDaRefeição) / 100;

        Math.Ceiling(valorDaGorjeta);
        TipValue.Text = valorDaGorjeta.ToString();

    }

    private void RoundDownButton_Clicked(object sender, EventArgs e)
    {
        //Arredondar o numero para o inteiro menor ao valor
        //Pegar o valor da refeição
        //Refeição multiplicado pela porcentagem 
        // Calcular o total
        //Arredondar
        //Exibir

        double valorDaRefeição = Convert.ToDouble(ValueEntry.Text);
        double valorDoSlider = Convert.ToDouble(TipPer.Text);
        double valorDaGorjeta = (valorDoSlider * valorDaRefeição) / 100;

        Math.Floor(valorDaGorjeta);
        TipValue.Text = valorDaGorjeta.ToString();


    }

    private void OnGorjetaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valorDoSlider = GorjetaSlider.Value;
        TipPer.Text = valorDoSlider.ToString();
    }
}