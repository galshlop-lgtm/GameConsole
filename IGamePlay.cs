namespace GameConsole.Interfaces;

public interface IGamePlay
{
    public string Name { get; set; }
    public int Score { get; set; }  

    public void Play();
   
}