KeySafe Key Management Utility
------------------------------
E.Butusov

1. What is it?

   KeySafe is a simply utility to store passwords and other sensitive data,
   protected with one master key.

2. How does it work?

   First you need to register the storage (File->Register storage). If it is
   a new storage, point to any empty file hidden somewhere. This is where all
   data will be stored (after encryption). Think of it as some kind of simple
   database. Next, you can add entries containing your sensitive data. Everytime
   you add entry, you are required to enter master key. This is the key that
   is used to storage encryption/decryption.
   To retreive data from database, you enter a query in search field. Then you
   must enter correct master key for the storage that is currently registered.
   Program displays entries. The key you entered is cached for 15 seconds after
   your query (you can run another query without reentering the code). Results
   are cleared from table after 1 minute (in case for some reason you leave
   program open). Passwords are hidden by default - to show them you must 
   place cursor in the gray cell. You can change that behavior in Edit menu.

 (...TODO...)
