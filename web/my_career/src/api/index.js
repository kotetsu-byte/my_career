import axios from "axios";

const API = axios.create({baseURL: 'https://localhost:7071/'});

export default API;