Here is a Python console application that validates a Sudoku board:

```python
def is_valid(board):
    for i in range(9):
        row = board[i]
        if not is_valid_block(row):
            return False

        column = [board[j][i] for j in range(9)]
        if not is_valid_block(column):
            return False

    for i in range(0, 9, 3):
        for j in range(0, 9, 3):
            square = []
            for x in range(3):
                for y in range(3):
                    square.append(board[i+x][j+y])
            if not is_valid_block(square):
                return False

    return True

def is_valid_block(block):
    filter_block = list(filter(lambda num: num != ".", block))
    return len(set(filter_block)) == len(filter_block)

def main():
    board = []
    for _ in range(9):
        row = input("Enter a row of the Sudoku board (use '.' for empty spaces): ")
        board.append(list(row))
    if is_valid(board):
        print("The Sudoku board is valid.")
    else:
        print("The Sudoku board is not valid.")

if __name__ == "__main__":
    main()
```

This console application asks the user to input each row of the Sudoku board. It then checks if the board is valid according to the rules of Sudoku. If the board is valid, it prints "The Sudoku board is valid." If the board is not valid, it prints "The Sudoku board is not valid."