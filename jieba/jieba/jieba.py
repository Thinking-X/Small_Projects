
import string

path="Aesop's Fables.txt"

with open(path,'r') as text:
    words=[raw_word.strip(string.punctuation).lower() for raw_word in text.read().split()]
    words_index=set(words)
    counts_dict={index:words.count(index) for index in words_index}

i=0
for word in sorted(counts_dict,key=lambda x:counts_dict[x],reverse=True):
    if i<20 :
        print ('{}--{} times'.format(word,counts_dict[word]))
        i+=1
