GameOfLife.GameOfLife game = new GameOfLife.GameOfLife(0);
game.Print();

while(true)
{
    game.Step();
    game.Print();
    Thread.Sleep(100);
}