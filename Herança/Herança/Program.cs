using Herança;

Aluno usuario = new Aluno();
usuario.setnome("João Paulo");
usuario.setIdade(30);
usuario.setSexo("Masculino");
usuario.setCurso("Engenharia Civil");
usuario.setRegistro(35);

Console.WriteLine("Nome: " + usuario.getNome());
Console.WriteLine("Idade: " + usuario.getIdade());
Console.WriteLine("Sexo: " + usuario.getSexo());
Console.WriteLine("Cursando o curso: " + usuario.getCurso());
Console.WriteLine("Número de registro acadêmico: " + usuario.getRegistro());
Console.ReadKey();