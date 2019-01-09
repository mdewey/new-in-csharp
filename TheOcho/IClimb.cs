namespace TheOcho
{
interface IDancer
{
    void Dance() => Dance("awkwardly");
    void Dance(string style);
}
}