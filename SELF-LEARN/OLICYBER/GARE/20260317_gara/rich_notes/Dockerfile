FROM node:24

RUN apt update && apt-get install -y dumb-init

WORKDIR /app
COPY src/package* ./

RUN npm ci

COPY src .

RUN npm run build

ENTRYPOINT ["/usr/bin/dumb-init", "--"]
CMD ["node", "--no-deprecation", "dist"]