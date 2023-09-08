module Blackjack where

import Cards
import RunGame
import Data.String (String)
import Data.Int (Int)

aCard1 :: Card
aCard1 = Card Ace Spades -- define your favorite card here

aCard2 :: Card
aCard2 = Card (Numeric 10) Hearts -- define another card here

aHand :: Hand
aHand = [aCard1, aCard2] -- a Hand with two Cards, aCard1 and aCard2

{-
size hand2
  = size [Card (Numeric 2) Hearts, Card Jack Spades]
  = size (Card ((Numeric 2) Hearts), (Card Jack Spades) [])
  = 1 + size ((Card Jack Spades) [])
  = 1 + 1 + size []
  = 1 + 1 + 0 
  = 2
-}

value :: Hand -> Int
value [] = 0
value hnd = sum [valueCard x | x <- hnd]

valueRank :: Rank -> Int
valueRank King        = 10
valueRank Queen       = 10
valueRank Jack        = 10
valueRank Ace         = 11
valueRank (Numeric x) = x

valueCard :: Card -> Int
valueCard (Card r s) = valueRank r

displayCard :: Card -> String
displayCard (Card r s) | r == King || r == Queen || r == Jack || r == Ace = show r  ++ " of " ++ show s
                       | otherwise = show (valueRank r)  ++ " of " ++ show s

displayHand :: Hand -> String
displayHand hnd = unwords (lines (unlines [displayCard x | x <- hnd]))

numberOfAces :: Hand -> Int
numberOfAces [] = 0
numberOfAces hnd = length [Ace | Card r _ <- hnd, r == Ace]
