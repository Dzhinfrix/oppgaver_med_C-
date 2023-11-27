int a = 3;
int b = 1;
int c = 2;
string max;

if (a > b) {
    max = "a";
}
else {
    max = "b";
}
if (b > c) {
    max = "b";
}
else {
    max = "c";
}
if (c > a) {
    max = "c";
}
else {
    max = "a";
}
Console.Write(max);