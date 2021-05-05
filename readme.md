# Generic-Test
Teste com classe Generica.<br>
Test with Generic class.

## public class MakeBooking

1. Em algum momento essas classes precisam ser salvas no banco de dados. <br>
At some point these classes need to be saved to the database.
```bash
public class Plan{}
public class Payment{}
public class Subscription{}
```
2. Um construtor que vai receber o numero de quartos.
```bash
 public MakeBooking(int rooms)
 {
    RoomsInUse = 0;
    Rooms = rooms;
 }
```
3. Método para efetuar uma reserva numa contagem partindo de 0,1,2,3....
```bash
public void Bookings()
{
    RoomsInUse++;
    if (RoomsInUse >= Rooms)
    {
       //Evento Fechado! Sala está cheia.
       OnRoomSoldOut(EventArgs.Empty);
    }
    else
    {
       Console.WriteLine("Quarto Reservado!");
    }
}
```
4. Criação de um [EventHandler] um manipulador de eventos, <n>
Um evento quando todas as salas estiverem todas completas.
```bash
public event EventHandler RoomSoldOutEvent;

protected virtual void OnRoomSoldOut(EventArgs test)
{
   EventHandler handler = RoomSoldOutEvent;
   handler?.Invoke(this, test);
}
```
5. ```No Program.cs``` Vamos ter o método que vai iniciar quantos quartos vão está disponiveis no hotel?
<br> e o número de reservas.
```bash
var room = new MakeBooking(2);
room.RoomSoldOutEvent += room.OnRoomSoldOut;

room.Bookings();
room.Bookings();
room.Bookings();
room.Bookings();
room.Bookings();
room.Bookings();
```


## NOTA

```EventHandler``` è um gerenciador de eventos, estando num método sem retorno e como parametro está sendo passado o delegate EventArgs
<br>Sempre que chamar o OnRoomSoldOut vai invocar o evento RommSoldOut que está sendo delegado.

```bash
public event EventHandler RoomSoldOutEvent;
```

