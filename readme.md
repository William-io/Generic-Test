# Generic-Test
Teste com classe Generica.<br>
Test with Generic class.

## class Plan, Payment, Subscription & DataContext
1. Em algum momento essas classes precisam ser salvas no banco de dados. 
```bash
public class Plan{}
public class Payment{}
public class Subscription{}
```
2.Método para salvar as infomações no banco de dados, onde vai funcionar tanto para pessoa, pagamento ou subscrição.
<br>Porque ela é generica. Logo por ser generica usamos o simbolo <> e T que é um tipo. 
<br>[entity] que são os Person,Plan e Subscription ```Note que para usar mais de um generico basta usar <T, U, V>```
<br> e instânciar no ```var context = new DataContext<Plan, Payment, Subscription>();  
```bash
public class DataContext<T> //Contexto de dados
{
    public void Save(T entity)
    {
        
    }
}
```
3. No Program.cs quando for instanciar a classe DataContext, basta dizer de que tipo é. DataContext<Plan> ou qualquer outra.
  <br>É só é aceito a instancia no save a classe que esteja sendo chamada no DataContext.
  <br>e tem que passar um Plan no Save() e não é permitido usar subscrição.
```bash
 static void Main(string[] args)
{                     
   var plan = new Plan();
   var context = new DataContext<Plan>();
   context.Save(plan); //
}
```
4. Classe DataContext 
```bash
public class DataContext<PL, PA, S>
{
    public void Save(PL entity)
    {
        
    }

    public void Save(PA entity)
    {

    }

    public void Save(S entity)
    {

    }
}
```
5. ```No Program.cs``` Importante! a ordem que o DataContext chama é a mesma do método Save() porque ele faz o depara. 
```bash
 class Program
{
    static void Main(string[] args)
    {
        var plan = new Plan();
        var payment = new Payment();
        var subscription = new Subscription();
        var context = new DataContext<Plan, Payment, Subscription>();

        context.Save(plan); 
        context.Save(payment);
        context.Save(subscription);
    }
}
```
6. Criar um limitador
```bash
public class DataContext<PL, PA, S>
         
where PL : Plan //P só pode ser do tipo Person e pode ser tanto classe como interface,
where PA : Payment
where S : Subscription

{
    public void Save(PL entity)
    {
        
    }

    public void Save(PA entity)
    {

    }

    public void Save(S entity)
    {

    }
}

public interface IPlan { }
<br>where PL : Plan ou IPlan
<br> 
public class Plan : IPlan {}

```
## NOTA

```DataContext<>``` Você pode ter herança, implementação de interface.

```bash
```

