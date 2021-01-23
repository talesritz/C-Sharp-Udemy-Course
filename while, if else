	var likes = new List<string>() { "Photo X. \n" };
                  
            while (true){
                Console.Write("Type a name: ");
                string temp = Console.ReadLine();

                if (temp == null || temp == "")
                {
                    break;
                }

                likes.Add(temp);
            }

            Console.WriteLine(likes.Count);
            if (likes.Count == 2) {
                Console.Write(likes[1] + " likes your post.");

            } else if (likes.Count == 3) {
                Console.WriteLine(likes[1] + " and " + likes[2] + " like your post.");

            }else if(likes.Count == 4){
                var extraPeople = likes.Count - 3;
                Console.WriteLine(string.Format("{0}, {1} and {2} other like your post.", likes[1], likes[2], extraPeople));

            } else {
                var extraPeople = likes.Count - 3;
                Console.WriteLine(string.Format("{0}, {1} and {2} others like your post.", likes[1], likes[2], extraPeople));    
            }
