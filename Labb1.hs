power1 :: Int -> Int -> Int
power1 n k = product (replicate k n)

power :: Int -> Int -> Int
power n k 
  | k < 0 = error "power: negative argument"
power n 0 = 1
power n k = n * power n (k-1)

power2 :: Integer -> Integer -> Integer
power2 n 0 = 1
power2 n k | even k == True = (n * n)^(k `div` 2)
           | otherwise = n * power2 n(k-1)

stepsPower :: Integer -> Integer
stepsPower k = k 


comparePower1 :: Int -> Int -> Bool
comparePower1 n k | power(n, k) == power1(n, k) = True
                  | otherwise       = False

test1 = power1 2 63 == power 2 63
test2 = power1 2 64 == power 2 64 
test3 = power2 3 17 == power1 3 17 
test4 = power2 4 12 == power 4 12 
test5 = power2 4 16 == power1 4 16 
