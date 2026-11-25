from base64 import b85encode
from string import printable
import random
import os

flag = os.getenv('FLAG', 'flag{REDACTED}')

alph = list(printable)
random.shuffle(alph)
alph = ''.join(alph)

def f(msg):
    enc = b85encode(msg)
    enc = enc.translate(bytes.maketrans(alph.encode(), printable.encode()))
    return enc.hex()

print(f(flag.encode()))
inp = bytes.fromhex(input('Hex message: '))
enc = f(inp)
print(f'B85 message: {enc}')