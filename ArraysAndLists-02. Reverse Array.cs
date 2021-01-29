Console.Write("Type your name: ");
            var userName = Console.ReadLine();
            char[] temp = new char[userName.Length];
            

            for (int i = 0; i < userName.Length; i++){
                temp[i] = userName[i];
                //Console.WriteLine(temp[i]);
            }

            char[] reverseName = new char[userName.Length];

            int nameLength = userName.Length - 1;
            for (int i = 0; i < userName.Length; i++){
                reverseName[nameLength] = temp[i];
                nameLength--;
            }

                
            Console.WriteLine(reverseName);
