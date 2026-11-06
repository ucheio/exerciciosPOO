using ExerciciosPOO;

//Exercicio 1
Pessoa p1 = new Pessoa();
p1.Nome = "Ucheio";
p1.Idade = 16;
p1.Cidade = "São Paulo";

p1.Apresentar();

Pessoa p2 = new Pessoa();
p2.Nome = "Marcooooooos";
p2.Idade = 17;
p2.Cidade = "São Paulo";

p2.Apresentar();

//Exercicio 2

Calculadora c1 = new Calculadora();
c1.Somar(8, 9);
c1.Multiplicar(2, 5);
c1.Subtrair(4, 56);

Calculadora.Dividir(6, 3);

//Exercicio 3

Veiculo v1 = new Veiculo();
v1.alterarVelocidade(34);

//Exercicio 4

Funcionario f1 = new Funcionario("Carlos", "Senior", 1500);

// f1.Nome = "Carlos";
// f1.Cargo = "Senior";

f1.AumentarSalario(10);
f1.ConsultarSalario();

//Exercicio 6

Livro l1 = new Livro();

Livro l2 = new Livro("Devorador de estrelas");

Livro l3 = new Livro("Harry Potter", "JK esqueci o resto");

Livro l4 = new Livro("LIVRO LAGAL", "CARA LEGAL", 90);