#coding:utf-8
'''
Created on 2014年9月27日

@author: WINTER
'''
import sys
try:
    s=raw_input('Enter something -->')
except EOFError:
    print '\nWhy did you do an EOF on me?'
    sys.exit()
except:
    print '\nSome error/exception occurred.'
    
print 'done'