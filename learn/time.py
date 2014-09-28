#coding:utf-8
'''
Created on 2014年9月27日

@author: WINTER
'''
import time

try:
    f = file('poem.txt')
    while True: # our usual file-reading idiom
        line = f.readline()
        if len(line) == 0:
            break
        time.sleep(5)
        print line,
finally:
    f.close()
    print 'Cleaning up...closed the file'