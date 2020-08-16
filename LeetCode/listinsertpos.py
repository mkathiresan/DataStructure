nums = [1,3,5,6]
target = 7
index = len(nums)
for idx, num in enumerate(nums):
    if num >= target:
        index = idx
        break
print(index)
