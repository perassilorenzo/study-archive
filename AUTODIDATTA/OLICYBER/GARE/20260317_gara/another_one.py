#!/usr/bin/env python3

import os
from base64 import b64encode

def xor(a,b):
    a, b = map(b64encode, [a,b])
    return bytes([x^y for x,y in zip(a,b)])

flag = os.getenv('FLAG', 'flag{redacted}').encode()

while True:
    key = os.urandom(len(flag))
    ctx = xor(key, flag)
    print(f'Eccoti un cifrato! {ctx.hex()}')
    ans = input('Ne vuoi un altro?\n> ')
    if ans.lower() == 'no':
        break
