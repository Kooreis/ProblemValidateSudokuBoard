def is_valid_block(block):
    filter_block = list(filter(lambda num: num != ".", block))
    return len(set(filter_block)) == len(filter_block)