""" stroka = 'пара-ра-рам рам-пам-папам па-ра-па-дам' """
stroka = 'как ве-тер сме-ёт лис-ти'

def verification (stroka):
  list_all = stroka.split()
  letter = ['а', 'у', 'о', 'ы', 'и', 'э', 'я', 'ю', 'ё', 'е']
  print(list_all)
  list_vowel = list()
  for i in list_all:
   	for k in i.split():
      print(k)

        	 
  print(list_vowel)
  
  if len(set(list_vowel))>0:
    print('Пам парам')
  else:
    print('Парам пам-пам')
  
verification(stroka)