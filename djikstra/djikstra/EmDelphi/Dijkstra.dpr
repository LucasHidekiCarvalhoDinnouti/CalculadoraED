program Dijkstra;

{$APPTYPE CONSOLE}

uses
  SysUtils;

var
    Matriz                                                    :  array of array of Integer;
    vertice                                                   :  Integer;
    d, pred, situacao, lista,custo                            :  array of integer;
    i,j, menor_indice, menor, origem,destino                  :  integer;


begin
  { TODO -oUser -cConsole Main : Insert code here }


 // origem := 1;
 // destino:= 6;
  //vertice      := 17; //arestas

  writeln('Informe os Vertices:');
  Readln(vertice);
  vertice := vertice +1;

  Writeln('Informe o vertice de origem:');
  Readln(origem);

  Writeln('Informe o vertice de destino:');
  Readln(destino);


  //inicializa matrizes
  SetLength(d,vertice);
  setlength(pred,vertice);
  SetLength(situacao,vertice);
  SetLength(Matriz,vertice);
  SetLength(lista,vertice);
  SetLength(custo,vertice);

  //inicializa variavéis
  menor_indice := 1;

//  for i:= 1 to vertice -1 do
//   begin
//     SetLength(Matriz[i],vertice);
//   end;

  //carrega matriz com adjacencias
{//  Matriz[1,2] := 1;
//  Matriz[2,1] := 1;
  Matriz[1,4] := 3;
  Matriz[4,1] := 3;
  Matriz[2,3] := 6;
  Matriz[3,2] := 6;
  Matriz[2,4] := 1;
  Matriz[4,2] := 1;
  Matriz[4,5] := 1;
  Matriz[5,4] := 1;
  Matriz[5,3] := 3;
  Matriz[3,5] := 3;
  Matriz[5,6] := 7;
  Matriz[6,5] := 7;
  Matriz[6,3] := 3;
  Matriz[3,6] := 3;
 }

   for i:=1 to vertice -1 do
    begin
      SetLength(Matriz[i],vertice-1);
    end;

 //inicializa matriz
     for i:= 1 to  vertice -1 do
     begin
       for j:= 1 to vertice -1 do
         begin
            Matriz[i,j]:=-1;
         end;
     end;

   Writeln('Obs: Para Vertices i,j sem arestas informe -1.');

   //carrega Matriz
   for i:= 1 to  vertice -1 do
     begin
       for j:= i+1 to vertice -1 do
         begin
            writeln('Informe custo vertice['+inttostr(i)+'],['+inttostr(j)+']:');
            Readln(Matriz[i,j]);
            Matriz[j,i]:=Matriz[i,j];
         end;
     end;






  //algoritimo dijkstra

  //passo 1
  writeln('***** Passo 1 *****');
  d[origem]       := 0;
  Writeln ('Vertice:'+inttostr(origem)+'Custo: '+inttostr(d[origem]));
  pred[origem]    := -1;
  Writeln ('Vertice:'+inttostr(origem)+'Pred: '+inttostr(pred[origem]));

Readln;

  //passo 2
        Writeln('****** Passo 2 **********');
       for i := 2 to vertice -1 do
         begin
           d[i]    := MaxInt;
           Writeln ('Vertice:'+inttostr(i)+'Custo: '+inttostr(d[i]));
           pred[i] := -1;
           Writeln ('Vertice:'+inttostr(i)+'Pred: '+inttostr(pred[i]));
         end;
Readln;

  //passo 3
     Writeln('****** Passo 3 **********');
      for i := 1 to vertice -1 do
         begin
           situacao[i]:= 0;
            Writeln ('Vertice:'+inttostr(i)+'Situacao: '+inttostr(situacao[i]));
         end;
Readln;
  repeat
  //passo 4
       Writeln('****** Passo 4 **********');
       menor := MaxInt;
       for i := 1 to vertice -1 do
         begin
           writeln('Valores:   i:'+inttostr(i));
           writeln(' situacao: '+inttostr(situacao[i])+' Distancia:'+inttostr(d[i])+' menor: '+inttostr(menor));
           if (situacao[i] = 0) and (D[i] < menor) then
            begin
                Writeln;
                Writeln('****** Selecionado Menor Custo **********');
                Writeln('menor custo:' + inttostr(d[i]));
                Writeln('Vertice    :'    + inttostr(i));
                menor := d[i];
                menor_indice := i;
                Writeln;
            end;
         end;
  Readln;
   //passo 5
       Writeln('****** Passo 5 **********');
        situacao[menor_indice] := 1;
        Writeln('Menor_indice: '+inttostr(menor_indice));
        Writeln('Situacao    :'+inttostr( situacao[menor_indice]));
    Readln;

  //passo 6
  Writeln('****** Passo 6 **********');
  for j := 1 to vertice -1 do
      begin
          Writeln('Vertice:'+inttostr(j)+'Custo:'+ inttostr(Matriz[menor_indice,j])+ 'Menor indice:'+inttostr(menor_indice)+' Valor j:'+inttostr(j));
          Writeln('Custo_menor_indice:'+inttostr(d[menor_indice])+' Custo_i_j: '+inttostr(Matriz[menor_indice,j]));
          if ((Matriz[menor_indice,j] <> -1))and((situacao[menor_indice]=-1) or(d[j] > Matriz[menor_indice,j]+d[menor_indice])) then
          begin
              Writeln;
              Writeln('****** Selecionado Menor Custo **********');

              writeln('Vertice M(i,j):'+inttostr(menor_indice)+','+inttostr(j)+'Custo:'+ inttostr(Matriz[menor_indice,j]));
              Writeln('Vertice_Pred:'+inttostr(menor_indice)+' Pred do Pred: '+inttostr(pred[menor_indice]));

              d[j]:=d[menor_indice] + Matriz[menor_indice,j];
              Pred[j]:=menor_indice;

              Writeln('Vertice D('+inttostr(j)+') Custo:'+IntToStr(d[j]));
              Writeln('Vertice_Pred:'+inttostr(menor_indice)+' Pred do Pred: '+inttostr(pred[menor_indice]));


              Writeln;
          end;
      end;
  //passo 7

    Writeln('****** Checa passo 7 **********');
    writeln ('Vertice: '+inttostr(menor_indice)+' Situacao:'+ inttostr(situacao[menor_indice]));
  until situacao[destino] = 1;


  //exibe o caminho com adjacencias

      for i:= Length(lista)  downto 0 do
      begin
        lista[i] := -1;
        custo[i] := -1;
      end;

    i:= 0;
   repeat

       lista[i] := menor_indice;
       custo[i] := d[menor_indice];
       menor_indice := pred[menor_indice];
       i:= i+1;
   until pred[menor_indice] = -1;


    Write ('Caminho: Inicio: Vertice:'+inttostr(origem)+', Custo:'+inttostr(d[origem])+'  ');

    for i:= Length(lista) downto 0 do
      begin
        if lista[i] <> -1 then
          begin
             Write('Vertice:'+inttostr(lista[i])+', Custo:'+inttostr(custo[i])+'  ');
          end;
      end;




  Write(':Fim');
  Readln;

end.