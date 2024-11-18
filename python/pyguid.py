import time
import uuid

start = time.perf_counter()

size = 100_000_000
while size:
    uuid.uuid4()
    size -= 1
print(f"Time: {time.perf_counter() - start}")