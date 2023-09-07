module Blackjack where

import Cards
import RunGame

aCard1 :: Card
aCard1 = Card Ace Spades -- define your favorite card here

aCard2 :: Card
aCard2 = Card (Numeric 10) Hearts -- define another card here

aHand :: Hand
aHand = [aCard1, aCard2] -- a Hand with two Cards, aCard1 and aCard2

{-
size hand2
  = size [Card (Numeric 2) Hearts, Card Jack Spades]
  = length hand2
  = 2
-}

x=10


numberOfAces = 1 

valueRank :: Rank -> Int
valueRank King       = 10
valueRank Queen      = 10
valueRank Jack       = 10
valueRank Ace | numberOfAces > 1 = 1
              | x > 21 = 1
              | otherwise = 11
valueRank (Numeric tal) = tal


valueCard :: Card -> Int
valueCard = undefined

displayCard :: Card -> String
displayCard (Card r s) = show r ++ " of " ++ show s

--display :: Hand -> String
--display hand = [show Rank  ++ " of " ++ show Suit |] 
