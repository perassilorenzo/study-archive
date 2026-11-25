# le tuple = insieme di  elementi

my_tuple = (2, 5, 9, 13, 25)

# le tuple non hanno per forza bisogno di parentesi

tuple_due = 2, 3, 7 

# l'indice inizia da 0

print(my_tuple[2])      # output: 9

# le tuple sono immutablili, non fuziona ne .append, del e non possiamo sostituire gli elementi dentro le tuple


# i set 

my_set = {"spam", "eggs", "bacon"}

# all'interno non possiamo avere più elementi uguali

set_due = {"spam", "eggs", "bacon", "spam"}
print(set_due)      # output: {"spam", "eggs", "bacon"}

# possiamo utilizzare .add
my_set.add("poker")
print(my_set)       # output: {"spam", "eggs", "bacon", "poker"}

