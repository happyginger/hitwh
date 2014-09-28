#coding:utf-8
'''
Created on 2014年9月27日

@author: WINTER
'''
import cPickle as p
shoplistfile='shoplist.data'
shoplist=['apple','mango','carrot']

f=file(shoplistfile,'w')
p.dump(shoplist,f)
f.close()

del shoplist

f=file(shoplistfile)
storedlist=p.load(f)
print storedlist