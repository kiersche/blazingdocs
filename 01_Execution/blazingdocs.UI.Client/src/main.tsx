import { useEffect, useRef, useState } from 'react'
import { createRoot } from 'react-dom/client'
import { Document, Page, pdfjs } from 'react-pdf'
import workerUrl from 'pdfjs-dist/build/pdf.worker.min.mjs?url'
import 'react-pdf/dist/Page/TextLayer.css'
import './style.css'

pdfjs.GlobalWorkerOptions.workerSrc = workerUrl

function Viewer({ file }: { file: File }) {
  const frame = useRef<HTMLDivElement>(null)
  const [width, setWidth] = useState(600)
  const [pages, setPages] = useState(0)
  const [page, setPage] = useState(1)
  const [zoom, setZoom] = useState(1)

  useEffect(() => {
    const element = frame.current!
    const observer = new ResizeObserver(([entry]) => setWidth(entry.contentRect.width))
    observer.observe(element)
    return () => observer.disconnect()
  }, [])

  return <section aria-label="PDF-Vorschau">
    <div className="toolbar">
      <button disabled={page <= 1} onClick={() => setPage(page - 1)}>Zurück</button>
      <span aria-live="polite">{pages ? `Seite ${page} von ${pages}` : 'PDF'}</span>
      <button disabled={page >= pages} onClick={() => setPage(page + 1)}>Weiter</button>
      <select aria-label="Zoom" value={zoom} onChange={e => setZoom(Number(e.target.value))}>
        {[0.75, 1, 1.25, 1.5, 2].map(value => <option key={value} value={value}>{value * 100} %</option>)}
      </select>
    </div>
    <div className="paper" ref={frame}>
      <Document file={file} onLoadSuccess={pdf => setPages(pdf.numPages)}
        loading="PDF wird geöffnet …" error="Dieses PDF konnte nicht geöffnet werden.">
        <Page pageNumber={page} width={Math.max(1, Math.round(width * zoom))}
          renderAnnotationLayer={false} loading="Seite wird geladen …" />
      </Document>
    </div>
  </section>
}

function App() {
  const [selection, setSelection] = useState<{file: File, id: number} | null>(null)
  return <>
    <header>Blazingdocs</header>
    <main>
      <aside>
        <h1>Dokumentansicht</h1>
        <label className="choose">PDF öffnen
          <input type="file" accept="application/pdf,.pdf" onChange={event => {
            const file = event.target.files?.[0]
            if (file) setSelection(previous => ({file, id: (previous?.id ?? 0) + 1}))
            event.target.value = ''
          }} />
        </label>
        {selection && <dl><dt>Dateiname</dt><dd>{selection.file.name}</dd>
          <dt>Dateigröße</dt><dd>{Math.ceil(selection.file.size / 1024).toLocaleString('de-DE')} KiB</dd></dl>}
      </aside>
      {selection ? <Viewer key={selection.id} file={selection.file} /> :
        <section className="empty"><h2>PDF-Vorschau</h2><p>Öffne einen Scan von deinem Gerät.<br/>Die Datei bleibt im Browser.</p></section>}
    </main>
  </>
}

createRoot(document.getElementById('root')!).render(<App />)
