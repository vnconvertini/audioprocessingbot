// Here are three separate lists of items that can be referenced in an example sentence. You can have up to 10 of these.
@ list food =
- pizza
- burger
- ice cream
- soda

@ list pet =
- cat
- dog

@ list sports =
- soccer
- tennis
- cricket
- basketball
- baseball
- football

// This is a list of phonetic pronunciations. 
// This adjusts the pronunciation of every instance of these words in a list or example training sentences. 
@ speech:phoneticlexicon
- cat/k ae t
- cat/f i l ai n

// Here are example training sentences. They are grouped into two sections to help organize them.
// You can refer to one of the lists we declared earlier by using {@listname}. You can refer to multiple lists in the same training sentence.
// A training sentence does not have to refer to a list.
# SomeTrainingSentence
- you can include sentences without a class reference
- what {@pet} do you have
- I like eating {@food} and playing {@sports}
- my {@pet} likes {@food}
