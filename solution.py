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