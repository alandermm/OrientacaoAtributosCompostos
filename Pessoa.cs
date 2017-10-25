using System;
public class Pessoa {
    public int idade { get; set; }
    public string nome { get; set; }
    public Endereco endereco { get; set; }

    /*public void mostrarDados(){
        Console.WriteLine(this.nome + ", " + this.idade + " - " + this.endereco.rua + ", " + this.endereco.numero + " - " + this.endereco.bairro);
    }*/

    public override string ToString(){
        return this.nome + ", " + this.idade + " - " + this.endereco.rua + ", " + this.endereco.numero + " - " + this.endereco.bairro;
    }

}