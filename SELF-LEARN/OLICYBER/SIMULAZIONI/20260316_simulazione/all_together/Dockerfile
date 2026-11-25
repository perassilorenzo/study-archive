FROM node:22

RUN apt update && apt-get install -y dumb-init

WORKDIR /app
COPY src/package* .

RUN npm ci

COPY src .

ENTRYPOINT ["/usr/bin/dumb-init", "--"]
CMD ["node", "index.js"]