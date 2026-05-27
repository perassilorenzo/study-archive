#!/usr/bin/env python3

flag = 'fcnp5}l3_ob6a_tse3g4r4d5{g4n_80n1se2'

def encrypt(flag):
    rows = [flag[i:i+6] for i in range(0, len(flag),6)]
    res = ""
    for i in range(len(rows)):
        for j in range(len(rows)):
            res += rows[j][(i+j) % len(rows[0])]
    return res

print(encrypt(flag))
