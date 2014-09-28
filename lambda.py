#coding:utf-8
'''
Created on 2014年9月27日

@author: WINTER
'''
def make_repeater(n):
    return lambda s:s*n

twice=make_repeater(2)

print twice('Ginger')
print twice(5)