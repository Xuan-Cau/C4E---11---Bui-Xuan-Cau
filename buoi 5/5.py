
def remove_dollar_sign():
    for i in range (len(str)) :
        old_str = str[i-1]
        new_str = old_str.replace("$","")
        str[i-1] = new_str
str = []
str.append ("10$")
str.append ("20$")
str.append ("30$")
print (str)
remove_dollar_sign()
print (str)



