#include <iostream>
#include <time.h>
#include <string>
using namespace std;

int suma(int a, int b)
{
    return a + b;
}

int different(int a, int b)
{
    return a - b;
}

int mult(int a, int b)
{
    return a * b;
}

int devisions(int a, int b)
{
    if (b == 0)
    {
        cout << "ERROR!";
        return 0;
    }
    else
    {
        return a / b;
    }
}


int main()
{
    srand(time(NULL));
    int a, b;
    cout << "Enter a\n"; cin >> a;
    cout << "Enter b\n"; cin >> b;
    int (*operation[4])(int a, int  b) = { suma, different, mult, devisions };

    int lenght = sizeof(operation) / sizeof(operation[0]);

    for (int i = 0; i < lenght; i++)
    {
        cout << "Result = " << operation[i](a, b) << "\n";
    }

    system("Pause");
}