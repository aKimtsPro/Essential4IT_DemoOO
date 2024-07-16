// See https://aka.ms/new-console-template for more information

using DemoStatic;


for(int i = 0; i < 500_000; i++)
{
    ToDispose disp = new ToDispose();
    
    disp.Dispose();
}