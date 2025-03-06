namespace DesafioEstacionamento.Models;

public class Estacionamento
{
	private decimal precoInicial = 0;
	private decimal precoPorHora = 0;
	List<string> veiculos = new List<string>();
	
	public Estacionamento(decimal precoInicial, decimal precoPorHora)
	{
		this.precoInicial = precoInicial;
		this.precoPorHora = precoPorHora;
	}

	public void AdicionarVeiculo()
	{
		Console.WriteLine("Digite a placa do veículo para estacionar: ");
		string placa = Console.ReadLine() ?? "";
		
		if(!string.IsNullOrWhiteSpace(placa))
		{
			veiculos.Add(placa);
			Console.WriteLine($"Veículo com a placa {placa} está estacionado");
		}
		else
		{
			Console.WriteLine("Placa inválida, digite novamente!");
		}
	}

	public void RemoverVeiculo()
	{
		Console.WriteLine("Digite a placa do veículo para remover: ");
		string placa = Console.ReadLine() ?? "";

		if(veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
		{
            int horas = 0;
			decimal valorTotal = 0;

            Console.WriteLine("Digite a quantidade de horas que o veículos permaneceu estacionado: ");
			horas = Convert.ToInt32(Console.ReadLine());

			valorTotal = precoInicial + precoPorHora * horas;

			veiculos.Remove(placa);

			Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

			

		} else
		{
			Console.WriteLine("Desculpe, esse veículo não foi estacionado aqui. Confira se digitou corretamente a placa.");
		}

	}

	public void ListarVeiculos()
	{
		if(veiculos.Any())
		{
			Console.WriteLine("Os veículos estacionados são:");
			foreach(string carros in veiculos)
			{
				Console.WriteLine($"{carros}");
			}
		}else
		{
			Console.WriteLine("Não há veículos estacionados.");
		}
	}
}
