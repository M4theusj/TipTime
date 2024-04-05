namespace TipTime;

public partial class Tip : ContentPage
    
{

	public Tip()
	{
		InitializeComponent();
        GorjetaSlider.Value = 5;
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
        double valorDaRefeicao = Convert.ToDouble(ValueEntry.Text);
        double valorDoSlider = GorjetaSlider.Value;
        double valorDaGorjeta = (valorDoSlider * valorDaRefeicao) / 100;

        TotalAmount.Text = Math.Ceiling(valorDaGorjeta + valorDaRefeicao).ToString("C2");
    }

    private void RoundDownButton_Clicked(object sender, EventArgs e)
    {
        double valorDaRefeicao = Convert.ToDouble(ValueEntry.Text);
        double valorDoSlider = GorjetaSlider.Value;
        double valorDaGorjeta = (valorDoSlider * valorDaRefeicao) / 100;

        TotalAmount.Text = Math.Floor(valorDaGorjeta + valorDaRefeicao).ToString("C2");
    }


    private void OnGorjetaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double valorDoSlider = GorjetaSlider.Value;
        TipPer.Text = valorDoSlider.ToString();


        // valro da conta
        double valorDaRefeicao = Convert.ToDouble(ValueEntry.Text);
        double valorDaGorjeta = (valorDoSlider * valorDaRefeicao) / 100;
        TipValue.Text = valorDaGorjeta.ToString();
        TotalAmount.Text = (valorDaRefeicao + valorDaGorjeta).ToString("C2");
    }

    private void ValueEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        double valorDaRefeicao = Convert.ToDouble(ValueEntry.Text);
        double valorDoSlider = GorjetaSlider.Value;
        double valorDaGorjeta = (valorDoSlider * valorDaRefeicao) / 100;

        TotalAmount.Text = (valorDaRefeicao + valorDaGorjeta).ToString("C2");
    }




}