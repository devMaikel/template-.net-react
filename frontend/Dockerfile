# FROM node:20-alpine
# WORKDIR /app
# COPY . .
# RUN npm install
# EXPOSE 80
# CMD [ "npm", "run", "prod"]


# watch / hot reload

FROM node:20-alpine
WORKDIR /app
COPY . .
RUN npm install
EXPOSE 80
CMD ["npm", "run", "dev"]
