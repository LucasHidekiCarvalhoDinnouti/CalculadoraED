using System;

public class Metodos
{
	public Metodos()
	{
	}

    public bool HaPrecedencia (string a, string b)
    {
        switch (a)
        {
            case "(":
                if (b == ")") return true;
                else return false; 
                break;

            case "^":
                if (b == "(") return false;
                else return true;
                break;

            case "*":
                if ((b == "(")||(b == "^")) return false;
                else return true;
                break;

            case "/":
                if ((b == "(" || "^")) return false;
                else return true;
                break;

            case "+":
                if ((b == "(" || "^" || "*" || "/")) return false;
                else return true;
                break;

            case "-":
                if ((b == "(" || "^" || "*" || "/")) return false;
                else return true;
                break;

            case ")":
                return false;
                break;
        }

    }

    public double CalculaExpressaoPosfixa(string expressao)
    {
        Pilha<double> umaPilha = new Pilha<double>();
        string [] simbolos = new string[7];

        for (int i=0; i< expressao.Length; i++)
        {
            string simbolo = expressao[i];
            if (!ehOperando(simbolo))
                umaPilha.empilhar(simbolo);
            else
            {
                string operando1 = umaPilha.Desempilhar();
                string operando2 = umaPilha.Desempilhar();
                string valor = CalculaSubExpressao(operando1, operando2, simbolo);
                umaPilha.empilhar(valor);
            }
        }
        return umaPilha.Desempilhar();
    }

    private string CalculaSubExpressao (string op1, string op2, string s)
    {
        double v1, v2 = 0;

        v1 = Convert.ToDouble(op1);
        v2 = Convert.ToDouble(op2);

        switch (s)
        {
            case "+": return (v1 + v2).ToString();
            case "-": return (v1 - v2).ToString();
            case "*": return (v1 * v2).ToString();
            case "/": return (v1 / v2).ToString();
            case "^": return Math.Pow(v1, v2).ToString();
        }
    }

    private bool ehOperando (string s)
    {
        if ((s == "(") || (s == ")") || (s == "+") ||
            (s == "-") || (s == "*") || (s == "/") || (s == "^"))
            return true;
        else
            return false;
    }

//    Function Calcula_Expressao_Posfixa(Cadeia_Posfixa:Cadeia):Integer {Real
//};
//Begin
//umaPilha := TPilha.Create();

//For Atual:=1 To Length(Cadeia_Posfixa) Do
//Begin
    //Simbolo:= Cadeia_Posfixa[Atual];
    //If Not(Simbolo In ["+","-","*","/","­"]) Then // É Operando
        //umaPilha.empilhar(Valor_de[Simbolo])
    //Else
    //Begin
        //Operando2 := umaPilha.Desempilhar();
        //Operando1 := umaPilha.Desempilhar();
        //Valor := Calcula_SubExpressao(Operando1, Simbolo, Operando2);
        //umaPilha.empilhar(Valor);
    //End;
//End;

//Resultado := umaPilha.desempilhar();
//Calcula_Expressao_Posfixa:= Resultado;
//End;
}
