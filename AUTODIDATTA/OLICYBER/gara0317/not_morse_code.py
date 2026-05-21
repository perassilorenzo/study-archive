#!/usr/bin/env python3

import os

flag = os.getenv('FLAG', 'flag{redacted}')

enc_flag = ""
chars = ['.', '-']
for i, c in enumerate(flag):
    # print(ord(c))
    # print(c)
    # print(i)
    # print(chr(ord(c)))
    enc_flag += chars[i % 2] * ord(c)

# print(enc_flag)

decrypt_flag = ""
crypt_flag = "-----------------------------------------------------------------------------------------------------------------------------"
count = 0

for i, c in enumerate(crypt_flag):
    count +=1
    

print(count)

flag = (chr(49), chr(109), chr(52), chr(103), chr(49), chr(110), chr(51), chr(95), chr(115), chr(51), chr(110), chr(100), chr(49), chr(110), chr(103), chr(95), chr(52), chr(110), chr(95), chr(115), chr(48), chr(115), chr(95), chr(119), chr(49), chr(116), chr(104), chr(95), chr(116), chr(104), chr(49), chr(115), chr(95), chr(99), chr(48), chr(100), chr(51), chr(95), chr(97), chr(102), chr(51), chr(57), chr(49), chr(51), chr(55), chr(100), chr(125))

print(flag)

print(decrypt_flag)