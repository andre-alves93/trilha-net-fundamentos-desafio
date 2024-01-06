namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        //CONSTRUTOR DA CLASSE
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        //MÉTODO PARA ADICIONAR UM VEÍCULO AO ESTACIONAMENTO
        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
 
            if (veiculos.Any(v => v.Equals(placa.ToUpper())))
            {
                Console.WriteLine("Já existe um veículo com essa placa.");
            }
            else
            {
                veiculos.Add(placa);
                Console.WriteLine("Veículo estacionado com sucesso!");
            }
        }
       
        //MÉTODO PARA REMOVER UM VEÍCULO DO ESTACIONAMENTO
        public void RemoverVeiculo()
        {
         Console.WriteLine("Digite a placa do veículo para remover:");
            
         string placa = Console.ReadLine();

        if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa.ToUpper());
              
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Placa não localizada, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        //MÉTODO PARA LISTAR OS VEICULOS ESTACIONADOS
        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var v in veiculos)
                {
                    Console.WriteLine(v);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}