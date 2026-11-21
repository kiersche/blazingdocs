import { defineConfig } from 'vite'

export default defineConfig({
  build: { outDir: '../blazingdocs.UI.Server/wwwroot/client', emptyOutDir: true },
  base: '/client/',
})
