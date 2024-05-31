// See https://aka.ms/new-console-template for more information

var A = 20;
var B = 12;
var C = 2;
var D = 0;
var E = 15;

var size = sizeof(int);

var first = minimum(A, B);
first = minimum(first, C);
first = minimum(first, D);
first = minimum(first, E);

var last = maximum(A, B);
last = maximum(last, C);
last = maximum(last, D);
last = maximum(last, E);

var max_a_b = maximum(A, B);
var max_a_c = maximum(A, C);
var max_a_d = maximum(A, D);
var max_a_e = maximum(A, E);

var max_b_a = maximum(B, A);
var max_b_c = maximum(B, C);
var max_b_d = maximum(B, D);
var max_b_e = maximum(B, E);

var max_c_a = maximum(C, A);
var max_c_b = maximum(C, B);
var max_c_d = maximum(C, D);
var max_c_e = maximum(C, E);

var max_d_a = maximum(D, A);
var max_d_b = maximum(D, B);
var max_d_c = maximum(D, C);
var max_d_e = maximum(D, E);

var max_e_a = maximum(E, A);
var max_e_b = maximum(E, B);
var max_e_d = maximum(E, D);
var max_e_c = maximum(E, C);

var min_ab_ac = minimum(max_a_b, max_a_c);
var min_ad_ae = minimum(max_a_d, max_a_e);

var minA = minimum(min_ab_ac, min_ad_ae);

var min_ba_bc = minimum(max_b_a, max_b_c);
var min_bd_be = minimum(max_b_d, max_b_e);

var minB = minimum(min_ba_bc, min_bd_be);

var min_ca_cb = minimum(max_c_a, max_c_b);
var min_cd_ce = minimum(max_c_d, max_c_e);

var minC = minimum(min_ca_cb, min_cd_ce);

var min_da_db = minimum(max_d_a, max_d_b);
var min_dc_de = minimum(max_d_c, max_d_e);

var minD = minimum(min_da_db, min_dc_de);

var min_ea_eb = minimum(max_e_a, max_e_b);
var min_ec_ed = minimum(max_e_c, max_e_d);

var minE = minimum(min_ea_eb, min_ec_ed);

var second = minimum(minA, minB);
second = minimum(second, minC);
second = minimum(second, minD);
second = minimum(second, minE);

var maxA = maximum(min_ab_ac, min_ad_ae);
var maxB = maximum(min_ba_bc, min_bd_be);
var maxC = maximum(min_ca_cb, min_cd_ce);
var maxD = maximum(min_da_db, min_dc_de);
var maxE = maximum(min_ea_eb, min_ec_ed);

var third = minimum(maxA, maxB);
third = minimum(third, maxC);
third = minimum(third, maxD);
third = minimum(third, maxE);


Console.WriteLine($"Number input: {A}, {B}, {C}, {D}, {E}");
Console.WriteLine("Number ascending order:");
Console.WriteLine("First:");
Console.WriteLine(first);
Console.WriteLine("Second:");
Console.WriteLine(second);
Console.WriteLine("Third:");
Console.WriteLine(third);
Console.WriteLine("Last:");
Console.WriteLine(last);

int minimum(int value1, int value2)
{
    return value2 + ((value1 - value2) & (value1 - value2 >> size));
}

int maximum(int value1, int value2)
{
    return value2 - ((value2 - value1) & (value2 - value1 >> size));
}

/* 
 
0 = 0000  ---> 0 & 1  ---> 0 ||  0 >> 4 -> 0000 --> 0
1 = 0001
2 = 0010
3 = 0011
4 = 0100
5 = 0101
6 = 0110
7 = 0111
8 = 1000
9 = 1001
10 = 1010
11 = 1011
12 = 1100
13 = 1101
14 = 1110
15 = 1111 

-1 = 11111111111111111111111111111111
-2 = 11111111111111111111111111111110
-3 = 11111111111111111111111111111101
-4 = 11111111111111111111111111111100
-5 = 11111111111111111111111111111011


lógica para minimo
val1 = 1, val2 = 3 -- saida 1
1 - 3 = -2
0001 - 0011 = 11111111111111111111111111111110 --> 11111111111111111111111111111110 >> 4 = -1

-2 & -1 = -2
11111111111111111111111111111110 
11111111111111111111111111111111
--------------------------------
11111111111111111111111111111110

3 + (-2) = 1 


-- maximo
val1 = 5, val2 = 3 --> saida 5

usando lógica anterior, temos o minimo = 3 
5 - 3 = 2
0101 - 0011 = 0010 --> 0010 >> 4 = 0 

2 & 0

0010
0000
----
0000

3 + 0 = 3 

tentando maximo:

3 - 5 = -2
0011 - 0101 = 11111111111111111111111111111110  --> 11111111111111111111111111111110 >> 4 = -1

-2 & -1

11111111111111111111111111111110
11111111111111111111111111111111
----
11111111111111111111111111111110

3 - (-2) = 5

invertendo val 1 e 2  para prova inversa: 

5 - 3 = 2 
0101 - 0011 = 0010 --> 0010 >> 4 = 0 

2 & 0

0010
0000
----
0000

5 - 0 = 5

 */
